#!/bin/bash

PARAMS=""

while (( "$#" )) ; do
    echo ""
    echo "num of args is $#"
    echo "doing arg $1"

    case "$1" in
        -f | --file )
            FARG=$2
            shift 2
            ;;
        -* )
            echo "Invalid option $1"
            break
            ;;
        * )
            echo "Non-flag arg $1"
            shift
            ;;
    esac
done

echo ""
echo "after arg parsing we've got $# many args and first arg is $1"

# while (( $# )) ; do
