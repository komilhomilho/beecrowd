import fs from "fs"
import path from "path";

var input = fs.existsSync('/dev/stdin')
  ? fs.readFileSync('/dev/stdin', 'utf8')
  : fs.readFileSync(path.join(process.cwd(), 'stdin.txt'), 'utf8');

var lines = input.trim().split(/\r?\n/);



const a = parseInt(lines.shift());
const b = parseInt(lines.shift());

console.log(`X = ${a + b}`);