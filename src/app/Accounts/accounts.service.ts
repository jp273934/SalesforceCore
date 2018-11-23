import { Injectable } from "@angular/core";
import { IAccount } from "./account";

@Injectable()
export class AccountService {
    getDefaultAccount() : IAccount {
        return  { Id : 0, Name : "", Type : "", AnnualPackagingSpend : 0}
    }
}