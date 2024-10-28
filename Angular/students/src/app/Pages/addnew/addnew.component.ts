import { Component } from '@angular/core';

@Component({
  selector: 'app-add-new', // Changed selector to match "AddNewComponent"
  standalone: true,
  imports: [], // You can add imports here if needed
  templateUrl: './addnew.component.html',
  styleUrls: ['./addnew.component.css' ] // Fixed typo (should be styleUrls)
})
export class AddNewComponent {
  // Your component logic here
}
