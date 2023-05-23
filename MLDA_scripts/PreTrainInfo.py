import pandas as pd
# import seaborn as sns
import matplotlib.pyplot as plt
from scipy.stats import shapiro
import os,sys

import time

rows = []
path = sys.argv[1]
btn1=sys.argv[2]

flag1=0
flag2=0
flag3=0
# Load the CSV data set into a pandas dataframe
start_time = time.time()

with open(path, 'r') as file:
    df = pd.read_csv(file)
# df = pd.read_csv(r"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv")

numerical_cols = df.select_dtypes(include=['int64', 'float64'])
# Select the non-numerical columns
non_numerical_cols = df.select_dtypes(exclude=['int64', 'float64'])
num_total_cols = df.shape[1]
num_non_numeric_cols = non_numerical_cols.shape[1]

if "0" in btn1:
    try:
        print('\nNumber of rows:', df.shape[0])
        print('Number of columns:', df.shape[1])
        print("Shape: ",df.shape)
        print(df.dtypes.value_counts())

        pct_non_numeric_cols = (num_non_numeric_cols / num_total_cols) * 100

        print(f"Percentage of non-numeric columns: {pct_non_numeric_cols:.2f}%")
    except PermissionError as e:
        print(f"Error: Invalid attempt")

if "1" in btn1:
    try:
        print("\nNo of Numerical Columns:",numerical_cols.shape[1])
        print('Numerical columns:\n', numerical_cols.columns.tolist())
    except PermissionError as e:
        print(f"Error: Invalid attempt")

if "2" in btn1:
    try:
        print("\nNo of Non Numerical Columns:",non_numerical_cols.shape[1])
        print('Non-numerical columns:\n', non_numerical_cols.columns.tolist())
    except PermissionError as e:
        print(f"Error: Invalid attempt")

if "3" in btn1:
    try:
        # Check for missing values
        missing_values = df.isnull().sum().sum()
        if missing_values > 0:
            print('\nThere are', missing_values, 'missing values in the data set.')
            flag1=1
        else:
            print('\nThere are no missing values in the data set.')
    except PermissionError as e:
        print(f"Error: Invalid attempt")

if "4" in btn1:
    try:
        # Check for duplicates
        duplicates = df.duplicated().sum()
        if duplicates > 0:
            print('\nThere are', duplicates, 'duplicate rows in the data set.')
            flag2=1
        else:
            print('\nThere are no duplicate rows in the data set.')
    except Exception as e:
        print(f"Error: Invalid attempt")

if "5" in btn1:
    try:
        numeric_cols = df.select_dtypes(include=['float64', 'int64']).columns.tolist()
        df=df[numeric_cols]

        # Calculate the correlation coefficient for each column in the dataframe
        corr_matrix = df.corr()

        # Display the correlation matrix
        print(corr_matrix.mask(abs(corr_matrix) < 0.5, 0))
        # print("\n",corr_matrix)
    except Exception as e:
        print(f"Error: {e}. Invalid Attempt")

if "6" in btn1:
    try:
        # Shapiro-Wilk test: The Shapiro-Wilk test is a statistical test.
        # tests the null hypothesis that the data comes from a normal distribution. If the p-value
        # is greater than a chosen level (usually 0.05),  data is considered normally distributed.
        # This test can be easily performed using Python libraries such as SciPy.
        for column in df.columns:
            if pd.api.types.is_numeric_dtype(df[column]):
                stat, p = shapiro(df[column])
                print('\nColumn:', column)
                print('Test statistic:', stat)
                print('p-value:', p)
                if p > 0.05:
                    print('The data is normally distributed.\n')
                    flag3+=1
                else:
                    print('The data is not normally distributed.\n')
                    flag3-=1
    except Exception as e:
        print(f"Error: {e}.Invalid Attempt")

if "7" in btn1:
    try:
        print("\n",df.head(10))
    except Exception as e:
        print(f"Error: {e}.Invalid Attempt")

if "8" in btn1:
    try:
        print("\n",df.tail(10))
    except Exception as e:
        print(f"Error: {e}.Invalid Attempt")

# sns.heatmap(corr_matrix, annot=True, cmap='coolwarm')
#
# # Set the plot title and axis labels
# plt.title('Correlation Matrix Heatmap')
# plt.xlabel('Variable')
# plt.ylabel('Variable')

# Display the plot
# plt.show()

# num_cols = df.select_dtypes(include='number').columns
# for col in num_cols:
#     print(col)
#     print(df[col].describe())
#     print('\n')

if "9" in btn1:
    # try:
    # Check for missing values
    missing_values = df.isnull().sum().sum()
    if missing_values > 0:
        flag1=1
    # Check for duplicates
    duplicates = df.duplicated().sum()
    if duplicates > 0:
        flag2=1
    for column in df.columns:
        if pd.api.types.is_numeric_dtype(df[column]):
            stat, p = shapiro(df[column])

            if p > 0.05:
                flag3+=1
            else:
                flag3-=1

    if(flag1+flag2+flag3==1,num_non_numeric_cols / num_total_cols>0.5):
        print("Data set is Partially Preprocessed")
        print("Approved to Training")
    elif(flag1+flag2+flag3>1,column_ratio>0.5):
        print("PreProcessing required before Training")
        print("Warning! Model outputs maybe Incorrect train on your own Risk.")
    else:
        print("Ready to Train")
        print("Approved to Training")


end_time = time.time()
elapsed_time = end_time - start_time

print(f"Time taken: {elapsed_time:.4f} seconds")
