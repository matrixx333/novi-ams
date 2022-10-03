import { Pipe, PipeTransform } from '@angular/core';
import { Member } from '../_models/member';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {
  transform(items: Member[], searchText: string): any[] {
    if (!items) { return []; }
    if (!searchText) { return items; }
    
    searchText = searchText.toLowerCase();

    return items.filter(item => {
      if (item) {
        return item.name.toLowerCase().includes(searchText);
      }
      return false;
    });
   }
}