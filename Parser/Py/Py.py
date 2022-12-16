
import numpy as np
from numpy import linalg
import pandas as pd
import requests
from io import BytesIO
from zipfile import ZipFile

power_data = pd.read_csv('power.csv')
sub_data = power_data.query('country in ("Latvia", "Lithuania", "Estonia") '
                            '& category in (4, 12, 21) & 2005 < year < 2010 & quantity >= 0')

print(f"Task 4. Total power consumption: {sub_data['quantity'].sum()}")
print('=====================')
