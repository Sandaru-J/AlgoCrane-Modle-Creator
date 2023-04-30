import numpy as np
import joblib
import os,sys


rows = []
modelfile = sys.argv[1]
array=sys.argv[2]
arrayD=list(map(float,array.split(",")))

# print("ModeL: ",modelfile," Array: ",arrayD)

# Load the saved model from a file
model_filename = modelfile
regressor = joblib.load(model_filename)

# input_data = []
# for i in range(regressor.coef_.shape[0]):
#     input_val = input(f"Enter the value for input variable {i+1}: ")
#     input_data.append(float(input_val))
# input_data = np.array(input_data).reshape(1, -1)

input_data = np.array(arrayD).reshape(1,-1)

y_pred = regressor.predict(input_data)

# Print the predicted value
print(y_pred[0])