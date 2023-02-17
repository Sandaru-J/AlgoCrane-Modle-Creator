import pandas as pd
import os, sys

rows = []
path = sys.argv[1]
check = sys.argv[2]

with open(path, 'r') as file:
    csvreader = pd.read_csv(file)

# print(newImprt.csvreader)
df=pd.DataFrame(csvreader)
rows,columns=df.shape
column_names = df.columns

numeric_columns = csvreader.select_dtypes(include='number')

number_columns = df.select_dtypes(include=['int64', 'float64']).columns
other_columns=df.select_dtypes(exclude=['int64', 'float64']).columns

means = numeric_columns.mean()
medians = numeric_columns.median()
modes = numeric_columns.mode().iloc[0]
print("Number of rows:", rows)
print("Number of columns:", columns,"\n")

print("Characheters contanin columns")
for other_column in other_columns:
    print("\t",other_column)

print("\nNumeric Coloumns")
for number_column in number_columns:
    print("\t",number_column)


print("\nMean:\n",means)
print("\n\nMedian:\n",medians)
print("\n\nMode:\n",modes)



