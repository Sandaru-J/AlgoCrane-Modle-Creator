import pandas as pd
import sys

rows = []
path = sys.argv[1]
flag1 = sys.argv[2]
saveChek = sys.argv[3]

# Load the dataset into a pandas dataframe
# df = pd.read_csv(r"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv")

with open(path, 'r') as file:
    df = pd.read_csv(file)

if "1" in flag1:
    if df.duplicated().any():
        # Check for duplicate rows
        duplicate_rows = df[df.duplicated()]
        num_duplicate_rows = len(duplicate_rows)
        perc_duplicate_rows = (num_duplicate_rows / len(df)) * 100

        # Check for duplicate values in each column
        num_duplicate_cols = df.apply(lambda x: x.duplicated().sum(), axis=0)
        perc_duplicate_cols = (num_duplicate_cols / len(df)) * 100
        duplicate_cols = num_duplicate_cols[num_duplicate_cols > 0].index.tolist()

        # Print the results
        print("\nNumber of duplicate rows: ", num_duplicate_rows)
        print("Percentage of rows containing duplicate data: {:.2f}%".format(perc_duplicate_rows))
        print("Rows containing duplicate data: \n", duplicate_rows)
        print("Columns containing duplicate data: ", duplicate_cols)
    else:
        print("No any Duplicated values.")

if "2" in flag1:
    row = df.shape[0]
    num_duplicate_rows = df.duplicated().sum()

    if df.duplicated().any():
        # Drop duplicate rows
        df.drop_duplicates(inplace=True)
        drp_ratio = num_duplicate_rows / row
        perc_drp = drp_ratio * 100

        if "0" in saveChek:
            print("\nPercentage of dropping rows:{:.2f}%".format(perc_drp))
            # Print number of dropped rows and current shape of dataframe
            print(f"{num_duplicate_rows} rows to be dropped.")

            if drp_ratio > 0.5:
                print("Warning!")
                print("More thant 50% of rows get dropped.")
                print("Consider before Saving")

        if "1" in saveChek:
            print(f"\nDropped {num_duplicate_rows} rows contain missing values.")
            print(f"Current shape: {df.shape}")
            # csvreader.to_csv(path, index=False)
            print("Files Saved with dropping duplicates.")

    else:
        print("No any Duplicated values.")
