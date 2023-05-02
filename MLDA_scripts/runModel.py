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

n_inputs =regressor.coef_.shape[0]
array_length = len(arrayD)

if array_length !=n_inputs:
    print("size Error")
    sys.exit()


input_data = np.array(arrayD).reshape(1,-1)

y_pred = regressor.predict(input_data)

# Print the predicted value
print(y_pred[0])