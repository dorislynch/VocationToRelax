
# react-native-vocation-to-relax

## Getting started

`$ npm install react-native-vocation-to-relax --save`

### Mostly automatic installation

`$ react-native link react-native-vocation-to-relax`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-vocation-to-relax` and add `RNVocationToRelax.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNVocationToRelax.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNVocationToRelaxPackage;` to the imports at the top of the file
  - Add `new RNVocationToRelaxPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-vocation-to-relax'
  	project(':react-native-vocation-to-relax').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-vocation-to-relax/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-vocation-to-relax')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNVocationToRelax.sln` in `node_modules/react-native-vocation-to-relax/windows/RNVocationToRelax.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Vocation.To.Relax.RNVocationToRelax;` to the usings at the top of the file
  - Add `new RNVocationToRelaxPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNVocationToRelax from 'react-native-vocation-to-relax';

// TODO: What to do with the module?
RNVocationToRelax;
```
  