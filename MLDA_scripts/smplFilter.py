import pandas as pd
import random
import sys

rows=[]
path=sys.argv[1]
btn=sys.argv[2]
smplPerc=sys.argv[3]
colName=sys.argv[4]
valName=sys.argv[5]
# savType=sys.argv[6]
fileName=sys.argv[6]
fileLoc=sys.argv[7]


csv_file_path = r'C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv'
# read CSV data into a Pandas dataframe
data = pd.read_csv(csv_file_path)

if "2" in btn:

    column_name=colName
    while column_name not in data.columns:
        if column_name not in data.columns:
            print(f"Column '{column_name}' not found in dataset.")

    value=valName
    while value not in data[column_name].unique():
        if value not in data[column_name].unique():
            print(f"No rows with '{column_name}' equal to '{value}' found in dataset.")

    if column_name:
        # filter the data to include only the specified value
        filtered_data = data[data[column_name] == value]
    else:
        filtered_data = data

    print(filtered_data.head(10))

if "4" in btn:
    # sample size as a percentage of total rows
    sample_percent =40

    # calculate sample size based on percentage
    sample_size = int(len(data) * int(sample_percent) / 100)

    # random sampling
    sample = data.sample(n=sample_size)
    print(sample)

if "1" in btn:
    # column_name = input("Enter column name to include in sample: ")
    column_name=colName
    while column_name not in data.columns:
        if column_name not in data.columns:
            print(f"Column '{column_name}' not found in dataset.")
            # column_name = input("Enter column name to include in sample: ")

    # value = input(f"Enter a value for '{column_name}' to include in sample: ")
    value=valName
    while value not in data[column_name].unique():
        if value not in data[column_name].unique():
            print(f"No rows with '{column_name}' equal to '{value}' found in dataset.")
            # value = input(f"Enter a value for '{column_name}' to include in sample: ")

    if column_name:
        # filter the data to include only the specified value
        filtered_data = data[data[column_name] == value]
    else:
        filtered_data = data
    type=True
    # save_as_new_file = True
    if type:

        filtered_data.to_csv(f"{fileLoc}/{fileName}.csv", index=False)
        print("Sample saved as new file:", f"{fileLoc}/{fileName}.csv")
    else:
        # update the original CSV file
        filtered_data.to_csv(csv_file_path, index=False)
        print("Sample updated in file:", csv_file_path)

if "5" in btn:
    column_name=colName
    while column_name not in data.columns:
        if column_name not in data.columns:
            print(f"Column '{column_name}' not found in dataset.")

    value=valName
    while value not in data[column_name].unique():
        if value not in data[column_name].unique():
            print(f"No rows with '{column_name}' equal to '{value}' found in dataset.")

    if column_name:
        # filter the data to include only the specified value
        filtered_data = data[data[column_name] == value]
    else:
        filtered_data = data
    type=False
    # save_as_new_file = True
    if type:
        # file_path=r'C:\Users\Sandaru\Desktop\Sophia\Datasets'
        filtered_data.to_csv(f"{fileLoc}/{fileName}.csv", index=False)
        print("Filtered data saved as new file:", f"{fileLoc}/{fileName}.csv")
    else:
        # update the original CSV file
        filtered_data.to_csv(csv_file_path, index=False)
        print("Filtered data updated in file:", csv_file_path)

