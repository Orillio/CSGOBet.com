let randomOnline = () => {
  return Math.floor(Math.random() * (400 - 300) + 300);
}
let interval = setInterval(randomOnline, 5000);
console.log(interval);