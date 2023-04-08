import pandas as pd
from sklearn.preprocessing import MinMaxScaler, StandardScaler
import matplotlib.pyplot as plt
import matplotlib
matplotlib.use('TkAgg')  # set the backend to TkAgg
import os,sys


rows = []
path = sys.argv[1]
method=sys.argv[2]
min=sys.argv[3]
max=sys.argv[4]
std=sys.argv[5]
decimals=sys.argv[6]
flag1=sys.argv[7]
checkSav=sys.argv[8]

float(std)
# Read in the dataset
with open(path, 'r') as file:
    df = pd.read_csv(file)
# print("min: ",min,"\t","max: ",max,"\t","std: ",std,"\t","method: ",method,"\t",)

# df = pd.read_csv(r"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv")
numeric_cols = df.select_dtypes(include=['float64', 'int64']).columns.tolist()
dataCols=df[numeric_cols]

columns_to_normalize = numeric_cols
# numeric_cols=numeric_cols.tolist();

normalize_method=method
normalize_method = int(normalize_method)
if "1" in flag1:
    # Create a scaler object based on the user's choice of normalization method
    if normalize_method ==1:
        scaler = MinMaxScaler()
        print("MinMax Scaller Selcted")
    elif normalize_method ==2:
        scaler = StandardScaler()
        print("Standard Scaller Selcted")
    elif normalize_method ==3:
        print("Decimal Scaling")
    else:
        print("Invalid normalization method.")

    # Prompt user to choose a range for minmax normalization (if applicable)
    if normalize_method == 1:
        min_range=min
        max_range=max
        if min_range:
            scaler.feature_range = (float(min_range), scaler.feature_range[1])
        if max_range:
            scaler.feature_range = (scaler.feature_range[0], float(max_range))
        print("Data set Normalized using Min Max scaller")
        df[columns_to_normalize] = scaler.fit_transform(df[columns_to_normalize])

    # Prompt user to choose number of standard deviations for zscore normalization (if applicable)
    if normalize_method == 2:
        std_devs=std
        if std_devs:
            scaler = StandardScaler(with_mean=True, with_std=True)
            scaler.mean_ = None
            scaler.std_ = None
            scaler.n_features_in_ = None
            scaler.fit(df[columns_to_normalize])
            scaler.std_ = scaler.std_ * float(std_devs)
        df[columns_to_normalize] = scaler.fit_transform(df[columns_to_normalize])

    if normalize_method ==3:
        for feature in dataCols:
            max_value = df[feature].max()
            j = 0
            while max_value >= 1:
                max_value /= 10
                j += 1
            df[feature] /= 10 ** j
            df[feature] = df[feature].round(int(decimals))

    # Normalize the selected columns using the scaler object

    print(df)
    print("\n")
    print(df[columns_to_normalize])

    if "1" in checkSav:
        df.to_csv(path, index=False)
        print("Normalized Data Updated")

    # Save the normalized dataset to a new file
    # output_file = input("Enter output file name: ")
    # df.to_csv(output_file, index=False)

if "2" in flag1:

    # Create a scaler object based on the user's choice of normalization method
    if normalize_method ==1:
        scaler = MinMaxScaler()
    elif normalize_method ==2:
        scaler = StandardScaler()
    elif normalize_method == 3:
        print("Decimal Scalling")
    else:
        print("Invalid normalization method.")

    # Prompt user to choose a range for minmax normalization (if applicable)
    if normalize_method == 1:
        min_range=min
        max_range=max
        if min_range:
            scaler.feature_range = (float(min_range), scaler.feature_range[1])
        if max_range:
            scaler.feature_range = (scaler.feature_range[0], float(max_range))
        df[columns_to_normalize] = scaler.fit_transform(df[columns_to_normalize])

    # Prompt user to choose number of standard deviations for zscore normalization (if applicable)
    if normalize_method == 2:
        std_devs=std
        if std_devs:
            scaler = StandardScaler(with_mean=True, with_std=True)
            scaler.mean_ = None
            scaler.std_ = None
            scaler.n_features_in_ = None
            scaler.fit(df[columns_to_normalize])
            scaler.std_ = scaler.std_ * float(std_devs)
        df[columns_to_normalize] = scaler.fit_transform(df[columns_to_normalize])

    if normalize_method == 3:
        for feature in dataCols:
            max_value = df[feature].max()
            j = 0
            while max_value >= 1:
                max_value /= 10
                j += 1
            df[feature] /= 10 ** j
            df[feature] = df[feature].round(int(decimals))
        # df[columns_to_normalize]=df[feature]
    # Normalize the selected columns using the scaler object

    # Set the boxplot colors
    colors = ['blue', 'red']

    # Plot the original and scaled data
    fig, axs = plt.subplots(1, 2, figsize=(10, 5))
    axs[0].boxplot(dataCols.values,  patch_artist=True, boxprops=dict(facecolor=colors[0]))
    axs[0].set_title('Original Data')
    axs[1].boxplot(df[columns_to_normalize],  patch_artist=True, boxprops=dict(facecolor=colors[1]))
    axs[1].set_title('Scaled Data')
    plt.show()