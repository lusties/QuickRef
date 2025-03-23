# QuickRef

## Installation

[Add from Git URL:](https://github.com/lusties/QuickRef.git?path=Packages/QuickRef)
```
https://github.com/lusties/QuickRef.git?path=Packages/QuickRef
```

## Example Usage

Here's an example of how to use the `QuickRef` package in Unity:

```C#
using Lustie.QuickRef;

public class ExampleBehaviour : MonoBehaviour
{
    //this will automatically reference these Unity Object in Inspector.
    [GetComponent, SerializeField]
    private AudioSource self_audioSource;

    [GetComponentInChildren]
    public Light child_light;

    [GetComponentInParent]
    public Camera parent_camera;
}
```

If you want to hide a field from the Inspector, use the `[NoDisplay]` attribute in order:

```C#
[SerializeField]    // this for serialize private field
[FindObjectOfType]  // find object of type
[NoDisplay]         // hide in normal inspector
private Camera noDisplayedCamera;
```

## Attribute List

## Attribute List

| Attribute                | Description                                                        |
|--------------------------|--------------------------------------------------------------------|
| `[GetComponent]`         | Automatically references the component on the same GameObject.     |
| `[GetComponentInChildren]` | Automatically references the component in the children of the GameObject. |
| `[GetComponentInParent]` | Automatically references the component in the parent of the GameObject. |
| `[FindObjectOfType]`     | Finds an object of the specified type in the scene.                |
| `[NoDisplay]`            | Hides the field from being displayed in the Inspector.             |


