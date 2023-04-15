import sys
import pandas as pd
import numpy as np

path=sys.argv[1]
col=sys.argv[2]
flag=sys.argv[3]
savcheck=sys.argv[4]

with open(path, 'r') as file:
    df = pd.read_csv(file)

column_name=col

if column_name not in df.columns:
    print("\nError: Column name not found in the dataset.")
elif not pd.api.types.is_numeric_dtype(df[column_name]):
    print("Error: Column is not numeric.")
    print("If you want to use this column, Encode and try again.")
else:
    # Calculate summary statistics
    mean = df[column_name].mean()
    median = df[column_name].median()
    std = df[column_name].std()
    Q1 = df[column_name].quantile(0.25)
    Q3 = df[column_name].quantile(0.75)
    IQR = Q3 - Q1

    if "1" in flag:
        z_score_threshold = 2  # Z-score threshold for considering data points as outliers
        iqr_multiplier = 1.5  # IQR multiplier for considering data points as outliers

        # Identify outliers based on mean and standard deviation
        outliers_mean_std = df.loc[abs(df[column_name] - mean) > z_score_threshold * std]
        outliers_mean_std['Deviation from Mean'] = abs(outliers_mean_std[column_name] - mean)

        mad = df[column_name].mad()
        mad_multiplier = 2  # MAD multiplier for considering data points as outliers
        outliers_median_mad = df.loc[abs(df[column_name] - median) > mad_multiplier * mad]
        outliers_median_mad['Deviation from Median'] = abs(outliers_median_mad[column_name] - median)

        # Identify outliers based on interquartile range (IQR)
        outliers_iqr = df.loc[(df[column_name] < Q1 - iqr_multiplier * IQR) | (df[column_name] > Q3 + iqr_multiplier * IQR)]
        outliers_iqr['Deviation from IQR'] = abs(outliers_iqr[column_name] - Q3 + Q1)

        # Print identified outliers with deviation information
        print("\nOutliers based on mean and standard deviation:")
        if outliers_mean_std.empty:
            print("No outliers found.")
        else:
            print(outliers_mean_std[[column_name, 'Deviation from Mean']])

        print("\nOutliers based on median and median absolute deviation (MAD):")
        if outliers_median_mad.empty:
            print("No outliers found.")
        else:
            print(outliers_median_mad[[column_name, 'Deviation from Median']])

        print("\nOutliers based on interquartile range (IQR):")
        if outliers_iqr.empty:
            print("No outliers found.")
        else:
            print(outliers_iqr[[column_name, 'Deviation from IQR']])

    if "2" in flag:
        # Identify outliers using IQR method
        lower_bound = Q1 - 1.5 * IQR
        upper_bound = Q3 + 1.5 * IQR
        outliers = df[(df[column_name] < lower_bound) | (df[column_name] > upper_bound)]

        # Print the identified outliers
        print("\nOutliers identified in column '{}':".format(column_name))
        print(outliers)

        replace_value = median  # Specify the value to replace outliers with
        df[column_name] = np.where((df[column_name] < lower_bound) | (df[column_name] > upper_bound), replace_value, df[column_name])

        mean_cleaned = df[column_name].mean()
        median_cleaned = df[column_name].median()
        std_cleaned = df[column_name].std()

        if "0" in savcheck:
            # Print the updated summary statistics after outlier replacement
            print("Summary statistics")
            print("Mean: {:.2f}".format(mean_cleaned))
            print("Median: {:.2f}".format(median_cleaned))
            print("Standard Deviation: {:.2f}".format(std_cleaned))
            print("Outliers successfully replaced")

        if "1" in savcheck:
            # df.to_csv(path, index=False)
            print("Replaced outlier file saved")


    if "3" in flag:
        lower_bound = Q1 - 1.5 * IQR
        upper_bound = Q3 + 1.5 * IQR
        outliers = df[(df[column_name] < lower_bound) | (df[column_name] > upper_bound)]

        # Drop the identified outliers from the dataset
        df = df[(df[column_name] >= lower_bound) & (df[column_name] <= upper_bound)]

        if "0" in savcheck:
            print("\nOutlier values Dropped.")
            print("Dataset after dropping outliers:")
            print(df.head(5))

        if "1" in savcheck:
            # df.to_csv(path, index=False)
            print("File saved dropping outliers.")
