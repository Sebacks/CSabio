//función para empezar la animación
function startAnimation() {
    document.getElementById("robot").style.MsAnimationPlayState = "running";
    document.getElementById("robot").style.MozAnimationPlayState = "running";
    document.getElementById("robot").style.OAnimationPlayState = "running";
    document.getElementById("robot").style.animationPlayState = "running";
}
//función para parar la animación
function stopAnimation() {
    document.getElementById("robot").style.MsAnimationPlayState = "paused";
    document.getElementById("robot").style.MozAnimationPlayState = "paused";
    document.getElementById("robot").style.OAnimationPlayState = "paused";
    document.getElementById("robot").style.animationPlayState = "paused";
}