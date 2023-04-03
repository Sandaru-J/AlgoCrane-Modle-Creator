import pandas as pd
from sklearn.linear_model import LinearRegression, LogisticRegression
from sklearn.model_selection import train_test_split
from sklearn.metrics import mean_squared_error, accuracy_score, confusion_matrix, mean_absolute_percentage_error
import joblib
import sys
import time

rows=[]
path=sys.argv[1]
btn=sys.argv[2]
trainCols=sys.argv[3]
trainTrgt=sys.argv[4]
ratio=sys.argv[5]
algBtn=sys.argv[6]
mdlName=sys.argv[7]
mdlLoc=sys.argv[8]

with open(path, 'r') as file:
    df = pd.read_csv(file)

non_numeric_cols = [col for col in df.columns if not pd.api.types.is_numeric_dtype(df[col])]
if len(non_numeric_cols) > 0:
    df = df.select_dtypes(include=[float, int])
else:
    pass
# drop rows with missing values
df = df.dropna()
start_time = time.time()
if "1" in btn:
    # input the name of the target variable
    target_var =trainTrgt
    if target_var not in df.columns:
        print(f"Error:Column '{target_var}' not found in dataset")
        sys.exit(1)

    train_cols_str = trainCols
    train_cols = train_cols_str.split(",")
    invalid_cols = []
    for train_col in train_cols:
        if train_col.strip() not in df.columns:
            invalid_cols.append(train_col.strip())
    if invalid_cols:
        print(f"Error: The following columns are not in the dataset: {', '.join(invalid_cols)}")
        train_cols = train_cols_str.split(",")

    test_size = int(ratio)/100
    # Split the data into training and testing sets
    X=df[train_cols]
    y = df[target_var]
    X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=test_size, random_state=42)

    if "1" in algBtn:
        # # Initialize the linear regression model
        lr = LinearRegression()

        # Train the model on the training set
        lr.fit(X_train, y_train)


        # Evaluate the model on the training set
        train_score = lr.score(X_train, y_train)
        print(f"The R-squared score on the training set is {train_score:.2f}")

        # Evaluate the model on the testing set
        test_score = lr.score(X_test, y_test)
        print(f"The R-squared score on the testing set is {test_score:.2f}")

        # # Evaluate the model on the testing set
        # y_pred = lr.predict(X_test)
        # mse = mean_squared_error(y_test, y_pred)
        # test_accuracy = 100 - mse/y_test.mean() * 100
        # print(f"The mean squared error on the testing set is {mse:.2f}")
        # print(f"The testing accuracy is {test_accuracy:.2f}%")
        # print("Model Trained Successfully")

        # Evaluate the model on the testing set
        y_pred = lr.predict(X_test)
        mse = mean_squared_error(y_test, y_pred)
        mape = mean_absolute_percentage_error(y_test, y_pred)
        # test_accuracy = 100 - mse/y_test.mean() * 100
        print(f"The mean squared error on the testing set is {mse:.2f}")
        print(f"The testing accuracy is {mape:.2f}%")

        print("Model Trained Successfully")




    if "0" in algBtn:
        # Initialize the logistic regression model
        lr = LogisticRegression()

        # Train the model on the training set
        lr.fit(X_train, y_train)

        # Evaluate the model on the training set
        train_pred = lr.predict(X_train)
        train_accuracy = accuracy_score(y_train, train_pred)*100
        print(f"The training accuracy is {train_accuracy:.2f}")

        # Evaluate the model on the testing set
        test_pred = lr.predict(X_test)
        test_accuracy = accuracy_score(y_test, test_pred)*100
        print(f"The testing accuracy is {test_accuracy:.2f}")

        # Print the confusion matrix
        conf_mat = confusion_matrix(y_test, test_pred)
        print("Confusion matrix:")
        print(conf_mat)

    end_time = time.time()
    elapsed_time = end_time - start_time

    print(f"Time taken: {elapsed_time:.4f} seconds")


if "2" in btn:
    # Get the input variable columns and output variable column from user
    input_cols=trainCols
    input_cols=input_cols.split(",")

    invalid_cols=[]
    for input_col in input_cols:
        if input_col.strip() not in df.columns:
            invalid_cols.append(input_col.strip())
    if invalid_cols:
        print(f"Error: Fallowing Columns are not in dataset:{', '.join(invalid_cols)}")
        sys.exit(1)

    output_col=trainTrgt
    if output_col not in df.columns:
        print(f"Error:Column '{output_col}' not found in dataset.")
        sys.exit(1)

    # Split the data into input and output variables
    X = df[input_cols].values
    y = df[output_col].values

    # Create a linear regression model and fit it to the data
    regressor = LinearRegression()
    regressor.fit(X, y)

    # # Save the model to a file
    # joblib.dump(regressor, model_filename)

    model_filename=mdlName
    # model_location = input("Enter the location to save the model (press enter to save in current directory): ")
    model_location=mdlLoc
    if model_location != "":
        model_filepath = model_location + "/" + model_filename
    else:
        model_filepath = model_filename
    joblib.dump(regressor, model_filepath)

    print("Model Created Successfully.")
    print(f"Model Saved at {model_location} from file name {model_filename}.")

    end_time = time.time()
    elapsed_time = end_time - start_time

    print(f"Time taken: {elapsed_time:.4f} seconds")