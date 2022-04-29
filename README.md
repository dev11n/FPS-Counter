# FPS-Counter
A FPS Counter for Unity games with memory efficiency in mind.
## What's so different?
Rather than directly appending the integer FPS value to your UI Text, this instead creates 999 strings which counts the value upwards.

This means that you can display your games FPS without generating any garbage, resulting in better performance.
