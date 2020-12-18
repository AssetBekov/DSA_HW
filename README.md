# Development of Software Applications Assignment

Home Work on Development of Software Applications Course

## Restaurant Management System

Design a .Net application by with a phone operator at a restaurant can manage table reservations:
- Can list available tables (depending on the time)
- Can assembly reservation by setting the time of the arrival, the number of guests, and name
of the person who books the table.
- Can list the daily menu

## Installation

For this purpose Microsoft Visual Studio with .Net extenction has been used



## Result

```python
!git clone https://github.com/azeghost/LMDB_Datasets # github with dataset

!pip install colorlog
from colorlog import ColoredFormatter
images_dir = 'data/.CBSD68' #Folder to images ( without name of the folder which we moved images before)
validation_percentage = 30
valid_format = 'png'
transformer = SRLmdbTransformer(image_dir = images_dir, trans_func=shrink_fn,
                              validation_pct = validation_percentage, valid_image_formats = valid_format)
transformer.transform_store(labels_fn=get_label_by_filename,image_dir=images_dir, lmdb_dir = lmdb_dir
           ,category='training',target_size=(481, 321),color_mode='rgb')
transformer.transform_store(labels_fn=get_label_by_filename,image_dir=images_dir, lmdb_dir = lmdb_dir
           ,category='validation',target_size=(481, 321),color_mode='rgb')
```

## Results and Visualization 
![Preupsampling](Images/pre%20upsampling%20results1.png)
![Preupsampling](Images/pre%20upsampling%20results2.png)
![Preupsampling](Images/pre%20upsampling%20results3.png)
![Preupsampling](Images/pre%20upsampling%20results4.png)

