import csv
import sys
import pandas as pd
import numpy as np
import os

rows = []
path = sys.argv[1]
flag1 = sys.argv[2]
saveChek=sys.argv[3]
# path = r"C:\Users\Sandaru\Desktop\Sophia\Datasets\test.csv"
with open(path, 'r') as file:
    csvreader = pd.read_csv(file)

if "1" in flag1:

    df_test=csvreader
    missing_values = ['n/a', 'na', '--', '-', 'unknown']

    # Replace with NaN
    df_test.replace(missing_values, np.nan, inplace=True)

    if df_test.isna().any().any():
        # Count missing values by column
        missing_count = csvreader.isna().sum()
        print("\nFeatures with missing values by columns")
        print(missing_count)
        print("Number of rows containing missing values: ",csvreader.isna().sum().sum())

        missing_values = ['n/a', 'na', '--', '-', 'unknown']
        # Replace values with NaN
        csvreader.replace(missing_values, np.nan, inplace=True)
        num_0f_all = csvreader.isna().sum().sum()
        print("Features with missing values with unKnown figures")
        print(csvreader.isnull().sum())

        total_values = csvreader.shape[0] * csvreader.shape[1]
        percentage_missing_rows = (num_0f_all/csvreader.shape[0]) * 100

        percentage_missing_values = (num_0f_all/total_values) * 100
        total_missing_rows = csvreader[csvreader.isnull().any(axis=1)].shape[0]
        print("Total number of rows containing missing values:", total_missing_rows)
        #
        # Printing the percentage of missing values
        print("Percentage of missing values by rows: {:.2f}%".format(percentage_missing_rows))
        print("Percentage of missing values by values: {:.2f}%".format(percentage_missing_values))

        # rows_with_missing_values = df.isnull().sum(axis=1)
        # rows_with_missing_values = rows_with_missing_values[rows_with_missing_values > 0.1 * df.shape[1]]
        #
        # # Printing the number of rows containing missing values more than 50% of the column count
        # print("Number of rows with more than 50% missing values:", rows_with_missing_values.shape[0])
    else:
        print("There are no missing values in the DataFrame")

if "2" in flag1:
    row=csvreader.shape[0]
    df_test=csvreader
    missing_values = ['n/a', 'na', '--', '-', 'unknown']
    # Replace with NaN
    df_test.replace(missing_values, np.nan, inplace=True)

    if df_test.isna().any().any():
        # Replace any occurrences of these string values with NaN
        csvreader.replace(missing_values, np.nan, inplace=True)

        init_rows=len(csvreader)
        csvreader.dropna(inplace=True)

        dropped = init_rows-len(csvreader)

        drp_ratio=dropped/row
        perc_drp=drp_ratio*100
        if "0" in saveChek:
            print("\nPercentage of dropping rows: {:.2f}%".format(perc_drp))
            print(f"{dropped} rows contain missing values to be dropped.")

            if drp_ratio >0.5:
                print("Warning!")
                print("More than 50% of rows get dropped.")
                print("Consider before Saving")
            # Print number of dropped rows and current shape of dataframe

        if "1" in saveChek:
            print(f"\nDropped {dropped} rows contain missing values.")
            print(f"Current shape: {csvreader.shape}")
            # csvreader.to_csv(path, index=False)
            print("Dropped Missing values Saved")
    else:
        print("This data set contain no missing values to drop")

if "3" in flag1:

    # df_test=csvreader
    # missing_values = ['n/a', 'na', '--', '-', 'unknown']
    # # Replace with NaN
    # df_test.replace(missing_values, np.nan)

    numerical_cols = csvreader.select_dtypes(include=np.number).columns
    missing_count = csvreader[numerical_cols].isna().sum()
    print("\nNumber of missing values in Numerical columns")
    print(missing_count)
    total_missing_rows = csvreader[csvreader.isnull().any(axis=1)].shape[0]
    print("Total number of rows containing all type of missing values:", total_missing_rows)

    if csvreader[numerical_cols].isna().any().any():
        if "0" in saveChek:
            csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].mean())
            print("Missing values filled with mean")
            missing_count_=csvreader[numerical_cols].isna().sum()
            print(missing_count_)

            total_missing_rows = csvreader[csvreader.isnull().any(axis=1)].shape[0]
            print("Total number of rows containing missing values:", total_missing_rows)
        if "1" in saveChek:
            csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].mean())
            missing_count_=csvreader[numerical_cols].isna().sum()

            total_missing_rows = csvreader[csvreader.isnull().any(axis=1)].shape[0]
            print("Total number of rows containing missing values:", total_missing_rows)
            # csvreader.to_csv(path, index=False)
            print("Data Set Saved with filled values.")

    else:
        print("No Numerical missing values contain here")
        print("Try 'Mode' or 'Median' to fill non numerical features")

if "4" in flag1:
    # run_script=0
    # # Define list of string values to replace with NaN
    # missing_values = ['n/a', 'na', '--', '-', 'unknown']
    #
    # # Replace string values with NaN
    # csvreader.replace(missing_values, np.nan, inplace=True)
    #
    # # Fill numerical columns with mean
    # num_numerical_filled=0
    # numerical_cols = csvreader.select_dtypes(include=[np.number]).columns.tolist()
    # if numerical_cols:
    #     if csvreader[numerical_cols].isna().any().any():
    #         num_numerical_filled = csvreader[numerical_cols].isna().sum().sum()
    #         csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].mean())
    #     else:
    #         print("\nNo missing values in numerical columns")
    #         run_script = run_script+1
    #
    #
    # # Fill categorical columns with mode
    # num_categorical_filled=0
    # categorical_cols = csvreader.select_dtypes(exclude=[np.number]).columns.tolist()
    # if categorical_cols:
    #     if csvreader[categorical_cols].isna().any().any():
    #         num_categorical_filled = csvreader[categorical_cols].isna().sum().sum()
    #         csvreader[categorical_cols] = csvreader[categorical_cols].fillna(csvreader[categorical_cols].mode().iloc[0])
    #     else:
    #         print("No missing values in categorical columns")
    #         run_script = run_script+1
    #
    # if run_script < 2:
    #     print(f"\nNumber of numerical rows filled: {num_numerical_filled}")
    #     print(f"Number of categorical rows filled: {num_categorical_filled}")
    #
    #     print(csvreader)
    #     tot=num_numerical_filled+num_categorical_filled
    #     print(f"Total of {tot} missing values filed using Mode of data set.")
    # else:
    #     pass
    run_script=0
    # Define list of string values to replace with NaN
    missing_values = ['n/a', 'na', '--', '-', 'unknown']

    # Replace string values with NaN
    csvreader.replace(missing_values, np.nan, inplace=True)

    # Fill numerical columns with mean
    num_numerical_filled=0
    numerical_cols = csvreader.select_dtypes(include=[np.number]).columns.tolist()

    if "0" in saveChek:
        if numerical_cols:
            if csvreader[numerical_cols].isna().any().any():
                num_numerical_filled = csvreader[numerical_cols].isna().sum().sum()
                csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].mean())
            else:
                print("\nNo missing values in numerical columns")
                run_script = run_script+1


        # Fill categorical columns with mode
        num_categorical_filled=0
        categorical_cols = csvreader.select_dtypes(exclude=[np.number]).columns.tolist()
        if categorical_cols:
            if csvreader[categorical_cols].isna().any().any():
                num_categorical_filled = csvreader[categorical_cols].isna().sum().sum()
                csvreader[categorical_cols] = csvreader[categorical_cols].fillna(csvreader[categorical_cols].mode().iloc[0])
            else:
                print("No missing values in categorical columns")
                run_script = run_script+1

        if run_script < 2:
            print(f"\nNumber of numerical rows filled: {num_numerical_filled}")
            print(f"Number of categorical rows filled: {num_categorical_filled}")
            print(csvreader)
            tot=num_numerical_filled+num_categorical_filled
            print(f"Total of {tot} missing values filed using Mode of data set.")
        else:
            pass

    run_script=0
    if "1" in saveChek:
        if numerical_cols:
            if csvreader[numerical_cols].isna().any().any():
                num_numerical_filled = csvreader[numerical_cols].isna().sum().sum()
                csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].mean())
            else:
                print("\nNo missing values in numerical columns")
                run_script = run_script+1

        # Fill categorical columns with mode
        num_categorical_filled=0
        categorical_cols = csvreader.select_dtypes(exclude=[np.number]).columns.tolist()
        if categorical_cols:
            if csvreader[categorical_cols].isna().any().any():
                num_categorical_filled = csvreader[categorical_cols].isna().sum().sum()
                csvreader[categorical_cols] = csvreader[categorical_cols].fillna(csvreader[categorical_cols].mode().iloc[0])
            else:
                print("\nNo missing values in numerical columns")
                run_script = run_script+1

        if run_script < 2:
            print(f"\nNumber of numerical rows filled: {num_numerical_filled}")
            print(f"Number of categorical rows filled: {num_categorical_filled}")
            # csvreader.to_csv(path,index=False)
            tot=num_numerical_filled+num_categorical_filled
            print(f"Total of {tot} missing values filed using Mode of data set.")
            print("File updated with filled missing values.")
        else:
            pass
if "5" in flag1:
    # run_script = 0
    # # Define list of string values to replace with NaN
    # missing_values = ['n/a', 'na', '--', '-', 'unknown']
    #
    # # Replace string values with NaN
    # csvreader.replace(missing_values, np.nan, inplace=True)
    #
    # # Fill numerical columns with mean
    # num_numerical_filled = 0
    # numerical_cols = csvreader.select_dtypes(include=[np.number]).columns.tolist()
    # if numerical_cols:
    #     if csvreader[numerical_cols].isna().any().any():
    #         num_numerical_filled = csvreader[numerical_cols].isna().sum().sum()
    #         csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].median())
    #     else:
    #         print("\nNo missing values in numerical columns")
    #         run_script = run_script+1
    #
    # # Fill categorical columns with mode
    # num_categorical_filled = 0
    # categorical_cols = csvreader.select_dtypes(exclude=[np.number]).columns.tolist()
    # if categorical_cols:
    #     if csvreader[categorical_cols].isna().any().any():
    #         num_categorical_filled = csvreader[categorical_cols].isna().sum().sum()
    #         csvreader[categorical_cols] = csvreader[categorical_cols].fillna(csvreader[categorical_cols].mode().iloc[0])
    #     else:
    #         print("No missing values in categorical columns")
    #         run_script = run_script+1
    #
    # if run_script < 2:
    #     print(f"\nNumber of numerical rows filled: {num_numerical_filled}")
    #     print(f"Number of categorical rows filled: {num_categorical_filled}")
    #
    #     print(csvreader)
    #     tot = num_numerical_filled + num_categorical_filled
    #     print(f"Total of {tot} missing values filed using Median of data set.")
    # else:
    #     pass
    run_script = 0
    # Define list of string values to replace with NaN
    missing_values = ['n/a', 'na', '--', '-', 'unknown']

    # Replace string values with NaN
    csvreader.replace(missing_values, np.nan, inplace=True)

    # Fill numerical columns with mean
    num_numerical_filled = 0
    numerical_cols = csvreader.select_dtypes(include=[np.number]).columns.tolist()

    if "0" in saveChek:
        if numerical_cols:
            if csvreader[numerical_cols].isna().any().any():
                num_numerical_filled = csvreader[numerical_cols].isna().sum().sum()
                csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].median())
            else:
                print("\nNo missing values in numerical columns")
                run_script = run_script+1

        # Fill categorical columns with mode
        num_categorical_filled = 0
        categorical_cols = csvreader.select_dtypes(exclude=[np.number]).columns.tolist()
        if categorical_cols:
            if csvreader[categorical_cols].isna().any().any():
                num_categorical_filled = csvreader[categorical_cols].isna().sum().sum()
                csvreader[categorical_cols] = csvreader[categorical_cols].fillna(csvreader[categorical_cols].mode().iloc[0])
            else:
                print("No missing values in categorical columns")
                run_script = run_script+1

        if run_script < 2:
            print(f"\nNumber of numerical rows filled: {num_numerical_filled}")
            print(f"Number of categorical rows filled: {num_categorical_filled}")

            print(csvreader)
            tot = num_numerical_filled + num_categorical_filled
            print(f"Total of {tot} missing values filed using Median of data set.")
        else:
            pass

    if "1" in saveChek:
        if numerical_cols:
            if csvreader[numerical_cols].isna().any().any():
                num_numerical_filled = csvreader[numerical_cols].isna().sum().sum()
                csvreader[numerical_cols] = csvreader[numerical_cols].fillna(csvreader[numerical_cols].median())
            else:
                print("\nNo missing values in numerical columns")
                run_script = run_script+1

        # Fill categorical columns with mode
        num_categorical_filled = 0
        categorical_cols = csvreader.select_dtypes(exclude=[np.number]).columns.tolist()
        if categorical_cols:
            if csvreader[categorical_cols].isna().any().any():
                num_categorical_filled = csvreader[categorical_cols].isna().sum().sum()
                csvreader[categorical_cols] = csvreader[categorical_cols].fillna(csvreader[categorical_cols].mode().iloc[0])
            else:
                print("No missing values in categorical columns")
                run_script = run_script+1

        if run_script < 2:
            print(f"\nNumber of numerical rows filled: {num_numerical_filled}")
            print(f"Number of categorical rows filled: {num_categorical_filled}")
            # csvreader.to_csv(path,index=False)
            tot = num_numerical_filled + num_categorical_filled
            print(f"Total of {tot} missing values filed using Median of data set.")
            print("File updated with filled missing values.")
        else:
            pass
