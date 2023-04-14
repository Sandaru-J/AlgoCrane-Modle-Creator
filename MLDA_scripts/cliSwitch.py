import sys
import pandas as pd

path=sys.argv[1]
flag=sys.argv[2]

with open(path, 'r') as file:
    df = pd.read_csv(file)

if "1" in flag:
    print("\n",df.head(5))
if "2" in flag:
    print(df.tail(5))

if "3" in flag:
    print(df.shape)

if "4" in flag:
    num_cols = df.select_dtypes(include=['int', 'float']).columns
    cat_cols = df.select_dtypes(include=['object']).columns.tolist()
    print("\nNumerical columns")
    print(num_cols)
    print("Categorical Cols")
    print(cat_cols)

if "5" in flag:
    print("\n",df.dtypes)