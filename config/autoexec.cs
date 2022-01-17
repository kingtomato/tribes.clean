//Widescreen fix for Tribes by emjay 
//!!!!!!! UPDATED VAR NAMES DUE TO LIMITED SPACE IN TRIBES.EXE !!!!!!!!
//put these lines into your autoexec and adjust them if needed
//its not limited to 1680x1050
//removed the NewMaxFov var, maxfov is now hardcoded to 180 
//removed the fov vars, just use the default $pref::playerfov (capped at 180)
$WSWidth = "1680";
$WSHeight = "1050";
$pref::PlayerFov = 118;
