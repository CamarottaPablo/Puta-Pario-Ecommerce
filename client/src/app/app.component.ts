import { Component, OnInit } from '@angular/core';
import { IProduct } from './shared/models/product';
import { BasketService } from './basket/basket.service';
import { AccountService } from './account/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  
  title = 'Puta Pario';
  products: IProduct[];

  constructor(private basketService: BasketService, private accountService: AccountService) {}

  ngOnInit(): void {   
    this.loadBasket();
    this.loadCurrentUser();
  }

  loadCurrentUser() {
    const token = localStorage.getItem('token');
    if (token) {
      this.accountService.loadCurrentUser(token).subscribe(() => {
        console.log('loaded user');
      }, error => {
        console.log(error);
      });
    };
  }

  loadBasket() {
    const basketId = localStorage.getItem('basket_id');
    console.log(basketId);
    if (basketId) {
      this.basketService.getBasket(basketId).subscribe(() => {
        console.log('Algo pasa');
      }, error => {
        console.log(error);
      });
    }
  }
}
