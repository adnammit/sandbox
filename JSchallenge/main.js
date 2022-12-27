qsa1 = function(node, selector) {
	return node.getElementsByTagName(selector);
}


// var matches = [];
// function recursivelySelectChildren(selectors, nodes){
//     if (selectors.length != 0){
//         for (var i = 0; i < nodes.length; i++){
//             recursivelySelectChildren(nodes[i].getElementsByTagName(selectors[0]), selectors.slice(1))
//         }
//     } else {
//         matches.push(nodes);
//     }
// }
// qsa2 = function (node, selector){
//     node = node || document;
//     recursivelySelectChildren(selector.split(" "), [node]);
//     return matches;
// }





qsa2 = function(node, selector) {
    var next = node;
		// split selectors
    selector.split(/\s+/g).forEach(function(sel) {
        var arr = [];
				// for the given element of the dom subtree, 
        (Array.isArray(next) ? next : [next]).forEach(function(el) {
            arr = arr.concat( [].slice.call(el.getElementsByTagName(sel) ));
        });
        next = arr;
    });
    return next;
}





// qsa2 = function(node, selector) {
//
// 	// separate the list of selectors
// 	var selectors = selector.split(" ");
//   var matches;
//
// 	selectors.forEach(function(j){
// 		console.log("our selectors are: " + j);
// 	});
//
//
//
//
//
//
//
// 	var children;
// 	var child;
// 	// LOOK THROUGH NODE TO FIND MATCHES FOR THE FIRST SELECTOR. THESE ARE THE PARENTS.
// 	var parents = node.getElementsByTagName(selectors[0]);
// 	//console.log("selectors[0] " + selectors[0]);
// 	//console.log("length of parents " + parents.length);
//
// 	// LOOK THROUGH EACH OF THE PARENTS TO FIND MATCHES OF THE SECOND SELECTOR
// 	if (parents.length > 0) {
// 		for (var i = 0; i < parents.length; i++) {
// 			children = parents[i].getElementsByTagName(selectors[1]);
// 			// ITERATE THROUGH EACH OF THE CHILDREN OF THE FIRST SELECTOR MATCHES.
// 			// APPEND THEM TO OUR LIST OF MATCHES TO BE RETURNED BY THE FUNCTION
// 			if (children.length > 0) {
// 				for (var i = 0; i < parents.length; i++) {
// 					child = children[i];
// 					console.log("child is " + child);
// 					matches.append(child);
// 				}
// 			}
// 		}
// 	}
//
//
//
//
//
//
// 	// // use the list of selectors to look through 'node' sequentially
// 	// for (var i = 0; i < selectors.length; i++) {
// 	// 	child = node.getElementsByTagName(selectors[i]);
// 	//   //alert(child);
// 	//   if (!child) {
// 	//   	break;
// 	//   }
// 	// 	// for each match of the full selector array in node, add the last selector to an array of matches
// 	//   if (i == (selectors.length - 1)) {
// 	//   	matches.push(child);
// 	//   }
// 	//   parent = child;
// 	// }
//
//
// 	return matches;
// }




// helper function for test results
map = function(results, fn) {
    return Array.prototype.slice.apply(results).map(fn);
}
