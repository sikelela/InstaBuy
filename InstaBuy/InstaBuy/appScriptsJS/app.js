function Welcome(artist) {
    return "<span style=color:red>" + artist + "</span>";
}
function musicPlayer() {
    var artist = "Cardi B";
    document.getElementById("msg").innerHTML = Welcome(artist);
}
function musicPlayerx() {
    var audioPlayer = document.getElementById('player');
    if (audioPlayer.paused) {
        audioPlayer.play();
    }
    else {
        audioPlayer.pause();
    }
}
//# sourceMappingURL=app.js.map