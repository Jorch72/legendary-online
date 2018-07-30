import { TestBed, inject } from '@angular/core/testing';

import { PlayerHandService } from './player-hand.service';

describe('PlayerHandService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PlayerHandService]
    });
  });

  it('should be created', inject([PlayerHandService], (service: PlayerHandService) => {
    expect(service).toBeTruthy();
  }));
});
