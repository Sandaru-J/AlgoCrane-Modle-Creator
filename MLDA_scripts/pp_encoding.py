import pandas as pd
from sklearn.preprocessing import LabelEncoder, OneHotEncoder, OrdinalEncoder
import os,sys

rows = []
technique=sys.argv[1]
otpType=sys.argv[2]
unknCat=sys.argv[3]
scale=sys.argv[4]

# Load dataset
url = 'https://archive.ics.uci.edu/ml/machine-learning-databases/adult/adult.data'
df = pd.read_csv(r"C:\Users\Sandaru\Desktop\Sophia\Datasets\UnListed\Medical\insurance.csv")
# df = pd.read_csv(url)
# print("technique: ",technique,"\t","outputype: ",otpType,"\t","unknown: ",unknCat,"\t","scale: ",scale,"\t")

# Assign generic column names to dataframe
num_cols = df.select_dtypes(include=['int', 'float']).columns
df.columns = ['col_' + str(i) if i in num_cols else 'cat_' + str(i) for i in range(len(df.columns))]
cat_cols = df.select_dtypes(include=['object']).columns.tolist()
dataCols=df[cat_cols]
data_Cols=df.select_dtypes(include=['object']).columns.tolist()

# Get user input for encoding options
encode_cols=dataCols

encode_type=technique
encode_type=int(encode_type)

output_type=int(otpType)

unknown_cat=int(unknCat)

scale_data=int(scale)

# Create instance of selected encoder
if encode_type == 1:
    encoder = LabelEncoder()
elif encode_type == 2:
    encoder = OneHotEncoder()
elif encode_type == 3:
    encoder = OrdinalEncoder()

d=0
for col in dataCols:
    # Check if label column is a 2D array
    if df[col].values.ndim > 1:
        df[col] = encoder.fit_transform(df[col].values.ravel())
        d=1
    if d >0:
        print("Warning:This data set contain more dimensions.Possibilty to failed process")

# use this if any dimensional problem occurs.
#     for col in cols_to_encode:
#         if df[col].dtype == 'object':
#             if encode_type == 'label':
#                 df[col] = encoder.fit_transform(df[col])
#             elif encode_type == 'one-hot':
#                 encoded_array = encoder.fit_transform(df[col].values.reshape(-1, 1))
#                 n_cols = encoded_array.shape[1]
#                 col_names = [col + '_' + str(i) for i in range(1, n_cols)]
#                 encoded_df = pd.DataFrame(encoded_array[:, 1:], columns=col_names)
#                 df = pd.concat([df, encoded_df], axis=1)
#                 df.drop(col, axis=1, inplace=True)
#         else:
#             print(f"Column '{col}' is not categorical and will not be encoded.")
# Encode selected columns
for col in encode_cols:
    if col not in df.columns:
        print(f"Column '{col}' not found in dataset.")
        continue

    # Encode column
    encoded_col = encoder.fit_transform(df[[col]])

    # Scale encoded data
    if scale_data == 2:
        encoded_col = (encoded_col - encoded_col.mean()) / encoded_col.std()

    # Handle unknown categories
    if unknown_cat == 2:
        most_common = encoder.classes_[encoded_col.argmax()]
        encoded_col[encoded_col == -1] = most_common
    elif unknown_cat == 3:
        encoded_col[encoded_col == -1] = len(encoder.classes_)

    # Output encoding
    if output_type == 1:
        if encode_type == 2:
            encoded_col=encoder.transform(df[[col]]).toarray()
            for i in range(encoded_col.shape[1]):
                df[f"{col}_{i}"] = encoded_col[:, i]
            df.drop(col, axis=1, inplace=True)  # Drop original column


        else:
            df[col] = encoded_col
    elif output_type == 2:
        for i in range(encoded_col.shape[1]):
            df[f"{col}_{i}"] = encoded_col[:, i]

    if isinstance(encoder, LabelEncoder):
        print(f"Encoding labels for '{col}': {encoder.classes_}")
    elif isinstance(encoder, OrdinalEncoder):
        print(f"Encoding labels for '{col}': {encoder.categories_[0].tolist()}")

# Print encoded data
print("\nEncoded dataset:")
print(df.head())
print("Data Set Encoded!")
