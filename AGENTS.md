# AGENTS.md - BaiDemo Unity Project

## Project Overview

This is a Unity 2D space shooter game project written in C#. The project uses Unity's Universal Render Pipeline (URP) and the Unity Input System for player controls.

## Build Commands

### Opening the Project
- Open the project in **Unity Editor 2023.x or later**
- Open `BaiDemo.slnx` in Rider or Visual Studio for C# development

### Building
- **Build & Run**: Press `Ctrl+B` in Unity Editor
- **Build for Platform**: Go to `File > Build Settings`, select target platform, click `Build`
- **Single Scene Build**: Add scene to Build Settings, build with scene selected

### Testing
- **Run Tests**: `Window > General > Test Runner` in Unity Editor, click `Run All`
- **Run Single Test**: In Test Runner, select specific test class or method, click `Run Selected`
- **Command Line**: Use `Unity -batchmode -runTests -projectPath <path> -testResults <results.xml>` for CI

## Code Style Guidelines

### General Conventions
- **Language**: C# (Unity-compatible)
- **Target Framework**: .NET Standard 2.1 / Unity's Mono runtime
- **Unity Version**: 2023.3+ (URP 17.x)

### Naming Conventions
- **Classes**: PascalCase (e.g., `PlayerMovement`, `EnemyHealth`)
- **Methods**: PascalCase (e.g., `UpdateFiring`, `ShootBullet`)
- **Variables**: camelCase (e.g., `flySpeed`, `lastBulletTime`)
- **Public Fields**: PascalCase (e.g., `public float FlySpeed` or `public float flySpeed` - match existing style)
- **Private Fields**: camelCase with `_` prefix optional (e.g., `_speed` or `speed`)
- **Constants**: PascalCase (e.g., `MaxHealth`)

### Formatting
- Use 4 spaces for indentation (Unity default)
- Use `var` for local variables when type is obvious from right side
- Keep lines under 120 characters when practical
- Use curly braces even for single-line blocks in control statements

### File Organization
```
Assets/
├── Scripts/           # C# scripts (create if needed)
├── Scenes/            # Unity scenes
├── Prefabs/           # Prefab assets
├── Settings/          # Project settings
└── [Asset folders]    # Sprites, audio, materials, etc.
```

### Code Structure
```csharp
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    // Public fields (exposed in Inspector)
    public float publicField;
    
    // Private fields
    private float privateField;
    
    // Unity lifecycle methods first, then custom methods
    private void Awake() { }
    private void Start() { }
    private void Update() { }
    private void FixedUpdate() { }
    
    // Custom public methods
    public void PublicMethod() { }
    
    // Custom private methods
    private void PrivateMethod() { }
}
```

### Imports
- Use explicit imports (e.g., `using UnityEngine;`)
- Group Unity imports first, then third-party, then custom
- Remove unused imports before committing

### Types
- Use C# primitive types (`int`, `float`, `bool`) over .NET types (`Int32`, `Single`, `Boolean`)
- Use `Vector2` for 2D, `Vector3` for 3D
- Use `GameObject` for scene objects, `Transform` for positioning
- Define custom types (classes, structs) for game entities

### Error Handling
- Use `null` checks before accessing components: `if (enemy != null)`
- Use `Debug.Log()`, `Debug.LogWarning()`, `Debug.LogError()` for logging
- Wrap potentially failing operations in try-catch for critical systems
- Handle `MissingReferenceException` when destroying objects

### Unity-Specific Guidelines
- Use `Time.deltaTime` for frame-rate independent movement
- Use `Time.time` for timing-based operations
- Cache component references in `Awake()` or `Start()` when reused
- Use `[SerializeField]` to expose private fields in Inspector
- Use `[SerializeField] private` for controlled Inspector exposure
- Prefer `private` with explicit exposure over `public` fields
- Use `GetComponent<T>()` for runtime access, assign in Inspector when possible

### Prefabs and Components
- Keep prefabs modular with single responsibility
- Use descriptive names for GameObjects in scene
- Group related components on same GameObject
- Use Tags and Layers for object categorization

### Input Handling
- Use Unity Input System (`UnityEngine.InputSystem`) for new input
- Use legacy `Input` class for simple cases (as seen in existing code)
- Handle input in `Update()` method

### Performance Considerations
- Avoid `GetComponent` calls in `Update()` - cache references
- Use object pooling for frequently spawned/destroyed objects (bullets)
- Use `Destroy` for runtime objects, don't destroy assets
- Limit physics calculations - use `FixedUpdate` for physics

## Project Structure

```
BaiDemo/
├── Assets/                  # Unity assets and scripts
│   ├── Bullet.cs           # Bullet behavior
│   ├── EnemyAttack.cs      # Enemy attack logic
│   ├── EnemyHealth.cs      # Enemy health management
│   ├── Health.cs           # Base health component
│   ├── PlayerHealth.cs     # Player health
│   ├── PlayerMovement.cs   # Player mouse movement
│   ├── PlayerShooting.cs   # Player shooting logic
│   ├── Scenes/             # Game scenes
│   └── Settings/           # URP and project settings
├── Packages/               # Unity package dependencies
├── ProjectSettings/        # Unity project configuration
├── UserSettings/           # Local user settings
└── BaiDemo.slnx           # Solution file for IDE
```

## Common Tasks

### Creating a New Script
1. Right-click in Assets > Create > C# Script
2. Name using PascalCase (matches class name)
3. Opens with template - replace with your implementation

### Running the Game
- Press Play button in Unity Editor
- Or use `Ctrl+P` / `Cmd+P`

### Testing Changes
1. Make changes in Editor
2. Press Play to test
3. Use `Ctrl+S` to save scenes
4. Check Console for errors (`Ctrl+Shift+C`)

## Editor Extensions

Recommended VS Code extensions (see `.vscode/extensions.json`):
- C# (Microsoft)
- Unity Code Snippets
- Unity Tools

## Additional Notes

- This project uses Force Text serialization (see `ProjectSettings/EditorSettings.asset`)
- Unity Test Framework is included in packages for unit testing
- The project uses Universal Render Pipeline - use URP-compatible materials and shaders
