function Welcome(artist: string) {
  return "<span style=color:red>" + artist +"</span>";
}

function musicPlayer() {
  let artist: string = "Cardi B";
  document.getElementById("msg").innerHTML = Welcome(artist);
}


function musicPlayerx() {
  let audioPlayer: HTMLMediaElement = <HTMLMediaElement>document.getElementById('player');
  if (audioPlayer.paused) {
    audioPlayer.play();
  }
  else {
    audioPlayer.pause();
  }
}