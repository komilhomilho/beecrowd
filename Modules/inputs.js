import fs from "fs";
import path from "path";

export const input = fs.existsSync('/dev/stdin')
  ? fs.readFileSync('/dev/stdin', 'utf8')
  : fs.readFileSync(path.join(process.cwd(), 'stdin.txt'), 'utf8');

export const lines = input.trim().split(/\r?\n/);