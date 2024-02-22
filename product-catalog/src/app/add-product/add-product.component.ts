import { Component } from '@angular/core';
import { ProductService } from '../service/product.service';
import { Product } from '../product';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-product',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.scss',
})
export class AddProductComponent {
  newProduct: Product = {};

  constructor(private productService: ProductService) {}

  addProduct() {
    this.productService.addProduct(this.newProduct).subscribe();
  }
}
