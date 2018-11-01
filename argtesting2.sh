#!/bin/bash

PARAMS=""

while (( "$#" )) ; do
    echo ""
    echo "num of args is $#"
    echo "doing arg $1"

    case "$1" in
        -f )
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
