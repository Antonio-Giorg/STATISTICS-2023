class DataStructures{
     arrayImplementation() {
        let array = [1, 2, 3, 4, 5];

        for (let elem of array) {
            console.log(elem);
        }

        // No direct equivalent for adding/removing elements in a fixed-size array in JavaScript
        // You can modify elements at a specific index
        array[1] = 6;

        let elementToFind = 3;
        if (array.includes(elementToFind)) {
            console.log("Trovato");
        }
    }

     listImplementation() {
        let list = [1, 2, 3, 4, 5];

        for (let elem of list) {
            console.log(elem);
        }

        // Adding elements
        list.push(7);
        // Removing elements
        let index = list.indexOf(4);
        if (index !== -1) {
            list.splice(index, 1);
        }

        let elem2 = list[3];
        list[1] = 6;

        console.log(list.includes(7));
    }

     dictionaryImplementation() {
        let dict = {
            "Hello": 3,
            "world": 4,
            "italy": 7
        };

        for (let key in dict) {
            console.log(key + ": " + dict[key]);
        }

        dict["New"] = 6;
        delete dict["Hello"];

        let elem2 = dict["New"];
        dict["New"] = 12;

        console.log("New" in dict);
    }

    sortedListImplementation(){
        let sortedList = []
        sortedList.append(9);
        sortedList.append(1);
        sortedList.append(4);

        sortedList = sortedList.sort();

        // Aggiunta di un elemento
        let elementToAdd = 5;
        sortedList = sortedList.append(elementToAdd).sort();

        // Get di un elemento
        let left = 0;
        let right = sortedList.length - 1;

        target = 6;
        indexElementToGet = null;

        // Eseguo una ricerca binaria dell'elemento per il get 
        // Questo metodo vale anche per CONTROLLARE SE UN ELEMENTO ESISTE all'interno della sorted list
        while (left <= right) {
            let mid = Math.floor((left + right) / 2);

            // Check if the middle element is the target
            if (sortedList[mid] === target) {
                elementToGet = mid; // Element found, return its index
            }

            // If the target is greater, ignore left half
            if (sortedList[mid] < target) {
                left = mid + 1;
            }
            // If the target is smaller, ignore right half
            else {
                right = mid - 1;
            }
        }

        valueToSet = 3;
        // Eseguo una ricerca binaria dell'elemento per il set
        while (left <= right) {
            let mid = Math.floor((left + right) / 2);

            // Check if the middle element is the target
            if (sortedList[mid] === target) {
                sortedList[mid] = valueToSet; // elemento trovato e settato il nuovo valore
            }

            // If the target is greater, ignore left half
            if (sortedList[mid] < target) {
                left = mid + 1;
            }
            // If the target is smaller, ignore right half
            else {
                right = mid - 1;
            }
        }
        


    }

    hashsetImplementation() {

        let hashSet = [];

        hashSet.append(4);
        hashSet.append(1);
        hashSet.append(3);

        

        // Aggiunta di un elemento se questo non è già incluso nel set
        let elementToAdd = 5;
        if (!hashSet.includes(elementToAdd)){
            hashSet.append(elementToAdd)
        }

        // Non è possibile effettuare get di un elemento e di set di un elemento causa le specifiche di un hashset

        // Controllo di un elemento presente 
        if (!hashSet.includes(1)){
            console.log("L'elemento è presente")
        }else{
            console.log("L'elemento non è presente")
        }
        
    }

       

     queueImplementation() {
        let queue = [];
        queue.push(1);
        queue.push(2);

        while (queue.length > 0) {
            let item = queue.shift();
            console.log(item);
        }

        queue.push(6);
        queue.shift();

        let firstElement = queue[0];
        console.log(queue.includes(2));
    }

     stackImplementation() {
        let stack = [];
        stack.push(1);
        stack.push(2);

        while (stack.length > 0) {
            let item = stack.pop();
            console.log(item);
        }

        stack.push(3);
        stack.pop();

        let topElement = stack[stack.length - 1];
        console.log(stack.includes(2));
    }
}
