adb shell getprop ro.build.version.sdk
adb shell wm size
adb shell wm density
java -jar bundletool-all-1.8.2.jar get-device-spec --output=./device-spec.json
pause