import csv
import sys
import pandas as pd
import os

rows = []
path = sys.argv[1]
flag1 = sys.argv[2]
flag2 = sys.argv[3]
flag3 = sys.argv[4]
flag4 = sys.argv[5]
# path = r"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv"
with open(path, 'r') as file:
    csvreader = pd.read_csv(file)

if "1" in flag1:

    print("No of Missing values by coloumn")
    # Count missing values by column
    missing_count = csvreader.isna().sum()

    # Filter columns that contain missing values
    missing_cols = missing_count[missing_count > 0]

    # Print count of missing values in each column
    print(missing_cols)

    missing_values = csvreader.isnull().sum()

    print("\n")
    total_values = csvreader.shape[0] * csvreader.shape[1]
    percentage_missing = (missing_values.sum()/total_values) * 100

    total_missing_rows = csvreader[csvreader.isnull().any(axis=1)].shape[0]
    print("Total number of rows containing missing values:", total_missing_rows)

    # Printing the percentage of missing values
    print("Percentage of missing values: {:.2f}%".format(percentage_missing))

    rows_with_missing_values = csvreader.isnull().sum(axis=1)
    rows_with_missing_values = rows_with_missing_values[rows_with_missing_values > 0.1 * csvreader.shape[1]]

    # Printing the number of rows containing missing values more than 50% of the column count
    print("Number of rows with more than 50% missing values:", rows_with_missing_values.shape[0])

if "2" in flag2:
    print("\n")
    print("Numerical Missing values columns filled with Mean values\n")
    print("Rows with missing values before filling:")
    print(csvreader[csvreader.isnull().any(axis=1)])

    # Fill missing values with mean of the column
    csvreader.fillna(csvreader.mean(), inplace=True)

    # Print the rows with missing values after filling
    print("Rows with missing values after filling:")
    print(csvreader[csvreader.isnull().any(axis=1)])

    missing_values = csvreader.isnull().sum()
    print("\n")
    total_values = csvreader.shape[0] * csvreader.shape[1]
    percentage_missing = (missing_values.sum()/total_values) * 100

    print("No of Missing values by coloumn")
    # Count missing values by column
    missing_count = csvreader.isna().sum()

    # Filter columns that contain missing values
    missing_cols = missing_count[missing_count > 0]

    # Print count of missing values in each column
    print(missing_cols)
    print("\n")

    total_missing_rows = csvreader[csvreader.isnull().any(axis=1)].shape[0]
    print("Total number of rows containing missing values:", total_missing_rows)

    # Printing the percentage of missing values
    print("Percentage of missing values:{:.2f}%".format(percentage_missing))

    rows_with_missing_values = csvreader.isnull().sum(axis=1)
    rows_with_missing_values = rows_with_missing_values[rows_with_missing_values > 0.1 * csvreader.shape[1]]

    # Printing the number of rows containing missing values more than 50% of the column count
    print("Number of rows with more than 50% missing values:", rows_with_missing_values.shape[0])


if "3" in flag3:
    # Print the rows with missing values before filling
    print("Rows with missing values before filling:")
    print(csvreader[csvreader.isnull().any(axis=1)])

    # Fill missing values with mode of the column
    csvreader.fillna(csvreader.mode().iloc[0], inplace=True)

    # # Set the file path where you want to save the CSV file
    # file_path = os.path.join(os.path.expanduser('~'), 'Documents', 'modified_tips.csv')
    #
    # # Create the directory if it doesn't exist
    # os.makedirs(os.path.dirname(file_path), exist_ok=True)
    #
    # # Save the modified dataframe to a CSV file
    # csvreader.to_csv(file_path, index=False)
    #
    # if os.path.exists(file_path):
    #     print(f"File saved successfully to {file_path}")
    # else:
    #     print("Error: file was not saved")
    # Print the rows with missing values after filling
    # print("Rows with missing values after filling:")
    # print(csvreader[csvreader.isnull().any(axis=1)])

    missing_values = csvreader.isnull().sum()
    print("\n")
    total_values = csvreader.shape[0] * csvreader.shape[1]
    percentage_missing = (missing_values.sum()/total_values) * 100

    print("All Missing values columns filled with Mode values\n")

    total_missing_rows = csvreader[csvreader.isnull().any(axis=1)].shape[0]
    print("Total number of rows containing missing values:", total_missing_rows)

    # Printing the percentage of missing values
    print("Percentage of missing values:{:.2f}%".format(percentage_missing))

    rows_with_missing_values = csvreader.isnull().sum(axis=1)
    rows_with_missing_values = rows_with_missing_values[rows_with_missing_values > 0.1 * csvreader.shape[1]]

    # Printing the number of rows containing missing values more than 50% of the column count
    print("Number of rows with more than 50% missing values:", rows_with_missing_values.shape[0])

if "4" in flag4:
    print("\n")
    print("Rows with missing values before filling:")
    print(csvreader[csvreader.isnull().any(axis=1)])

    # Fill missing values with the median of the column
    csvreader.fillna(csvreader.median(), inplace=True)

    print("Rows with missing values after filling:")
    print(csvreader[csvreader.isnull().any(axis=1)])

    print("Data set missing values filled with Median")

    print("No of Missing values by coloumn")
    # Count missing values by column
    missing_count = csvreader.isna().sum()

    # Filter columns that contain missing values
    missing_cols = missing_count[missing_count > 0]

    # Print count of missing values in each column
    print(missing_cols)

    missing_values = csvreader.isnull().sum()
    total_values = csvreader.shape[0] * csvreader.shape[1]
    percentage_missing = (missing_values.sum()/total_values) * 100

    # Printing the percentage of missing values
    print("Percentage of missing values:{:.2f}%".format(percentage_missing))

    rows_with_missing_values = csvreader.isnull().sum(axis=1)
    rows_with_missing_values = rows_with_missing_values[rows_with_missing_values > 0.1 * csvreader.shape[1]]

    # Printing the number of rows containing missing values more than 50% of the column count
    print("Number of rows with more than 50% missing values:", rows_with_missing_values.shape[0])