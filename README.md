##GUI Assistance for [FidelityFX-CLI](https://github.com/GPUOpen-Effects/FidelityFX-CLI)

![Screensho 01](https://i.imgur.com/XiFA8o0.png "Screensho 01")

**Prefix:** The prefix or word before the number sequence starts.

**Starting Number:** number of first image after prefix

**Ending Number:**  number of last image after prefix

**Output Prefix:** the prefix all the output images will have

**Input Extension:** aka image type
*Supported Formats: BMP, PNG, ICO, JPG, TIF, GIF*

For example, to upscale two images which are `render0.png` and `render1.png` and get output as `ups0.png` and `ups1.png` these are the settings required:

Prefix: `render`
Starting Number: `0`
Ending Number: `1`
Output Prefix: `ups`
Input Extension: `.png`

##### Protip: Use absolute or relative directories in both prefix fields to get input and store output in different folder.
*Does not create folders automatically. Only use existing folders.*
