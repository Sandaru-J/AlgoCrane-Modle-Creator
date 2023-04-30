import sys
import joblib

rows = []
modelfile = sys.argv[1]

# Load the trained model
model_filename = modelfile
regressor = joblib.load(model_filename)

# Get the number of inputs required by the model
n_inputs = regressor.coef_.shape[0]

# Print the number of inputs required
print(f'The model requires {n_inputs} input(s).')