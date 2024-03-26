# Cube Auto UV - Automatically adjust UV coordinates for stretched cube meshes

Cube Auto UV is a C# script for Unity that automatically adjusts the UV coordinates of a cube mesh based on its parent's scale. This feature is particularly useful when working with cubes that are stretched or scaled unevenly, as it ensures that the texture applied to the cube does not become distorted but rather repeats seamlessly.

## How it Works

The script `CubeAutoUV.cs` extends the `MonoBehaviour` class in Unity. It provides boolean parameters to control which axes (x, y, z) should have their UV coordinates adjusted. By default, all axes are enabled for adjustment.

When the `Start()` function is called, the script automatically adjusts the UV coordinates of the cube mesh according to the scale of its parent object. This ensures that the texture remains consistent even when the cube is stretched or scaled.

## Usage

1. Attach the `CubeAutoUV.cs` script to a GameObject in your scene.
2. Assign the `cube` variable to the GameObject containing the cube mesh.
3. Optionally, you can control which axes (x, y, z) should have their UV coordinates adjusted by setting the corresponding boolean variables (`xAxis`, `yAxis`, `zAxis`).
4. Ensure that the material applied to the cube mesh is set up to handle adjusted UV coordinates.
5. Play the scene or call the `AutoUV()` method to automatically adjust the UV coordinates.

## Example

An example usage of Cube Auto UV would be creating a long and high wall from a single cube by stretching it without needing to manually adjust UVs.

## License

[![GNU AGPLv3 Image](https://www.gnu.org/graphics/agplv3-155x51.png)](https://www.gnu.org/licenses/agpl-3.0.html)

This program is Free Software: You can use, study share and improve it at your
will. Specifically you can redistribute and/or modify it under the terms of the
[GNU Affero General Public License](https://www.gnu.org/licenses/agpl-3.0.html) as
published by the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
