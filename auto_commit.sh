# If you fork the repository and find yourself making changes to README.md,
# Feel free to use this script to automate pushing your changes to your fork.


#!/bin/bash

# Check if directory is provided as an arugment.
if [ -z "$1" ]; then
  echo "Usage: $0 <path_to_readme>"
fi

README_FILE="$1"

#Check if the file exists
if [ ! -f "$README_FILE" ]; then
  echo "Error: README does not exists at "$README_FILE""
  exit 1
fi

COMMIT_MESSAGE="Update README: $(date +'%Y-%m-%d %H:%M:%S')"

#Stage the file
git add "$README_FILE"

#Commit the changes 
git commit -m "$COMMIT_MESSAGE" || { echo "Commit failed!"; exit 1; }

#Push changes to repository
git push origin || { echo "Push failed!"; exit 1; }

echo "Commit and push successful!"
