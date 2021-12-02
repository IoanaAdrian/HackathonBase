export  class postCommand {
    leftLed: boolean = false;
    rightLed: boolean = false;
    valid: boolean = false;
    key: string = "pula";
    constructor(leftLed:boolean,rightLed:boolean,valid:boolean,key:string){
        this.leftLed = leftLed;this.rightLed = rightLed;this.valid = valid;this.key=key;
    }
}
