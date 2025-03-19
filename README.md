# QuickRef

## Installation

Add from Git URL:
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

