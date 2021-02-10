function calculateWalkTime(steps, footprintLength, speed) {
    let speedMpS = speed / 3.6;
    let distance = steps * footprintLength;
    let breakMinutes = Math.trunc(distance / 500);
    let time = ((distance) / speedMpS) + Math.trunc(breakMinutes * 60);
    let hours = Math.trunc(time / 3600);
    let minutes = Math.trunc(time / 60);
    let seconds = Math.round(time % 60);
    if (hours < 10) {
        hours = '0' + hours;
    }
    if (minutes < 10) {
        minutes = '0' + minutes;
    }
    if (seconds < 10) {
        seconds = '0' + seconds;
    }
    console.log(`${hours}:${minutes}:${seconds}`);
}
