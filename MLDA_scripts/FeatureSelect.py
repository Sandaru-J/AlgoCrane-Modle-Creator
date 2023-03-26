import pandas as pd
import numpy as np
from sklearn.feature_selection import RFECV
from sklearn.linear_model import LinearRegression
from sklearn.metrics import r2_score
from sklearn.model_selection import cross_val_score
import sys

row=[]
path=sys.argv[1]
btn=sys.argv[2]
btn2=sys.argv[6]
con_cols=sys.argv[3]
target_col=sys.argv[4]
num_cols=sys.argv[5]

with open(path, 'r') as file:
    data = pd.read_csv(file)

# select only numerical columns
numerical_cols = data.select_dtypes(include=np.number).columns

data = data[numerical_cols]
column_names=numerical_cols.tolist()
if "1" in btn:
    print(','.join(numerical_cols))

if "2" in btn:
    # # features to consider
    # select the columns to consider
    if "1" in btn2:
        feature_cols=numerical_cols
    else:
        feature_cols = con_cols.split(",")

    if int(num_cols)>=len(feature_cols):
        print("Exceed column count in the dataset")
        print("Enter new count less than:",len(feature_cols))
        sys.exit(1)

    for col in feature_cols:
        if col.strip() not in column_names:
            print(f"'{col.strip()}' column is not in the dataset")
            sys.exit(1)

    # ensure that the target column is included in the list of feature columns
    if target_col not in feature_cols:
        print(f"Error: Column '{target_col}' not found in dataset.")
        sys.exit(1)
        feature_cols.append(target_col)
    # subset the data to include only the selected columns
    data = data[feature_cols]

    y = data[target_col]

    # remove the target column from the feature set
    X = data.drop(columns=target_col)

    # check if the dataset has missing values
    if data.isnull().values.any():
        # drop rows with missing values
        data = data.dropna()

        X = X.loc[data.index, :]
        y = y.loc[data.index]
        print("Rows with missing values have been dropped.")
    else:
        print("No missing values found.")

    # create a linear regression model
    model = LinearRegression()

    rfecv = RFECV(estimator=model, cv=5, scoring='neg_mean_squared_error')

    rfecv.fit(X, y)

    num_cols_to_keep=int(num_cols)

    # print the selected features
    selected_cols = list(X.columns[rfecv.support_][:num_cols_to_keep])
    print(f"\nSelected {num_cols_to_keep} Features:")
    for element in selected_cols:
        print(element)


if "3" in btn:
    try:
        # feature_cols = con_cols.split(",")
        if "1" in btn2:
            feature_cols=numerical_cols
            # print(numerical_cols)
        else:
            feature_cols = con_cols.split(",")

        if int(num_cols)>=len(feature_cols):
            print("Exceed column count in the dataset")
            print("Enter new count less than:",len(feature_cols))
            sys.exit(1)

        for Col in feature_cols:
            if Col.strip() not in column_names:
                # print(f"'{col.strip()}' column is not in the dataset")
                sys.exit(1)

        if target_col not in feature_cols:
            # print(f"Error: Column '{target_col}' not found in dataset.")
            sys.exit(1)
            feature_cols.append(target_col)
        # subset the data to include only the selected columns
        data = data[feature_cols]

        y = data[target_col]

        # remove the target column from the feature set
        X = data.drop(columns=target_col)

        # check if the dataset has missing values
        if data.isnull().values.any():
            # drop rows with missing values
            data = data.dropna()
            # drop corresponding rows from the feature set and target variable
            X = X.loc[data.index, :]
            y = y.loc[data.index]
            # print("Rows with missing values have been dropped.")
        else:
            pass

        # create a linear regression model
        model = LinearRegression()
        rfecv = RFECV(estimator=model, cv=5, scoring='neg_mean_squared_error')

        # fit the RFECV object to the data
        rfecv.fit(X, y)
        # get user input for number of best columns to keep
        num_cols_to_keep=int(num_cols)

        # print the selected features
        selected_cols = list(X.columns[rfecv.support_][:num_cols_to_keep])
        # print(f"\nSelected {num_cols_to_keep} Features:")
        print("\n")
        for col in selected_cols:
            # for col in selected_cols:
            X_col = X[[col]]
            model.fit(X_col, y)
            mse = -np.mean(cross_val_score(model, X_col, y, cv=5, scoring='neg_mean_squared_error'))
            print(f"MSE of {col}: {mse:.4f}")
    except Exception as e:
        print(f"Error: {e}.Invalid Attempt")

if "4" in btn:
    try:
        if "1" in btn2:
            feature_cols=numerical_cols
            # print(numerical_cols)
        else:
            feature_cols = con_cols.split(",")

        if int(num_cols)>=len(feature_cols):
            print("Exceed column count in the dataset")
            print("Enter new count less than:",len(feature_cols))
            sys.exit(1)

        for col in feature_cols:
            if col.strip() not in column_names:
                # print(f"'{col.strip()}' column is not in the dataset")
                sys.exit(1)
        if target_col not in feature_cols:
            # print(f"Error: Column '{target_col}' not found in dataset.")
            sys.exit(1)
            feature_cols.append(target_col)
        # subset the data to include only the selected columns
        data = data[feature_cols]

        y = data[target_col]

        # remove the target column from the feature set
        X = data.drop(columns=target_col)

        # check if the dataset has missing values
        if data.isnull().values.any():
            # drop rows with missing values
            data = data.dropna()
            # drop corresponding rows from the feature set and target variable
            X = X.loc[data.index, :]
            y = y.loc[data.index]
            # print("Rows with missing values have been dropped.")
        else:
            pass

        # create a linear regression model
        model = LinearRegression()

        rfecv = RFECV(estimator=model, cv=5, scoring='neg_mean_squared_error')

        # fit the RFECV object to the data
        rfecv.fit(X, y)

        num_cols_to_keep=int(num_cols)

        # print the selected features
        selected_cols = list(X.columns[rfecv.support_][:num_cols_to_keep])
        # print(f"\nSelected {num_cols_to_keep} Features:")
        print("\n")
        for col in selected_cols:
            # for col in selected_cols:
            X_col = X[[col]]
            model.fit(X_col, y)
            r2 = r2_score(y, model.predict(X_col))
            print(f"R^2 of {col} : {r2:.4f}")
    except Exception as e:
        print(f"Error: {e}.Invalid Attempt")